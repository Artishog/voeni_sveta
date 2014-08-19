#!/bin/bash

if [[ "$1" = "" || "$2" = "" || "$3" = "" ]] ; then
	echo "Usage: update-taxi-app.sh <prod|qa|dev> <db password> <asterisk api server> <sip server> <http password>"
	exit
fi

APPTYPE="$1"
DBPASS="$2"
ASTERISKAPI="$3"
SIPSERVER="$4"
HTTPPASS="$5"
ASTERISKAPILOCAL="$6"
FIXOFFICE="$7"

if [[ "$APPTYPE" != "prod" && "$APPTYPE" != "qa" && "$APPTYPE" != "dev" ]] ; then
	echo "Unknown apptype \"$APPTYPE\""
	exit
fi

HTTPAUTH=""

if [ "$HTTPPASS" != "" ] ; then
	HTTPAUTH="${APPTYPE}:${HTTPPASS}@"
fi

echo "[+ updating $APPTYPE]"
pushd `dirname $0`/../"$APPTYPE" &> /dev/null

echo "[+ unzip build archive]"
pushd ../tools/builds/"$APPTYPE" &> /dev/null

unzip build-"$APPTYPE".zip &> /dev/null
rm build-"$APPTYPE".zip &> /dev/null

popd &> /dev/null
echo "[- unzip build archive]"

echo "[+ copy]"

cp -R ../tools/builds/"$APPTYPE"/* .

find public -type f -exec chmod a+r {} &> /dev/null \;
find public/* -type d -exec chmod a+rx {} &> /dev/null \;
find framework -type f -exec chmod a+r {} \;
find framework -type d -exec chmod a+rx {} \;
find protected -type f -exec chmod a+r {} 2> /dev/null \;
find protected -type d -exec chmod a+rx {} \;
echo "[- copy]"

echo "[+ cleanup]"
pushd public/assets &> /dev/null
[ "`ls * 2> /dev/null`" != "" ] &&  rm -r *
popd &> /dev/null
chmod a+rwx public/assets
chmod a+rwx protected/runtime
echo "[- cleanup]"

echo "[+ fix]"

if [ "$HTTPPASS" != "" ] ; then
	FTO="public/.htaccess"

	mv $FTO "${FTO}.tmp"
	echo 'AuthType Basic' > $FTO
	echo 'AuthName "Restricted Files"' >> $FTO
	echo 'AuthBasicProvider file' >> $FTO
	echo 'AuthUserFile /var/www/tools/htpasswd' >> $FTO
	echo "Require user $APPTYPE" >> $FTO
	echo '' >> $FTO
	cat "${FTO}.tmp" >> $FTO
	rm "${FTO}.tmp"
fi

FTO="public/index.php"
mv $FTO "${FTO}.tmp"
sed "s/^defined('YII_DEBUG')/\/\/ defined('YII_DEBUG')/" "${FTO}.tmp" > $FTO
rm "${FTO}.tmp"

chmod a+r public/.htaccess
chmod a+rw public/pub
chmod a+rw protected/runtime/*.log 2> /dev/null
echo "[- fix]"

echo "[+ config]"
FTO="protected/config/common.server.php"

echo "<?php" > $FTO
echo "" >> $FTO
echo "return array(" >> $FTO
echo "	'components' => array(" >> $FTO
echo "		// 'cache' => array(" >> $FTO
echo "		//	'class' => 'CApcCache'," >> $FTO
echo "		// )," >> $FTO
echo "		'db' => array(" >> $FTO
echo "			'connectionString' => 'mysql:host=127.0.0.1;dbname=taxi_$APPTYPE'," >> $FTO
echo "			'username' => 'root'," >> $FTO
echo "			'password' => '8561703'," >> $FTO
echo "			//'password' => '$DBPASS'," >> $FTO
echo "			// 'schemaCachingDuration' => 3600," >> $FTO
echo "		)," >> $FTO
echo "		'dbAddresses' => array(" >> $FTO
echo "			'connectionString' => 'mysql:host=127.0.0.1;dbname=taxi_addresses'," >> $FTO
echo "			'username' => 'root'," >> $FTO
echo "			'password' => '8561703', " >> $FTO
echo "			//'password' => 'hg7478124fbkas'," >> $FTO
echo "			// 'schemaCachingDuration' => 3600," >> $FTO
echo "		)," >> $FTO
echo "	)," >> $FTO
echo "	'params' => array(" >> $FTO
echo "		'sms' => array(" >> $FTO
echo "			'fromNumber' => '107'," >> $FTO
echo "			'kannelUrl' => 'http://127.0.0.1:13011/cgi-bin/sendsms'," >> $FTO
echo "			'kannelUsername' => 'sms'," >> $FTO
echo "			'kannelPassword' => 'fh3Iu47yrg'," >> $FTO
echo "			'kannelSmsc' => 'life'," >> $FTO
echo "			'dlrUrl' => 'http://${HTTPAUTH}${APPTYPE}.taxi.dancosoft.com/site/dlr'," >> $FTO
echo "		)," >> $FTO
echo "		'asteriskApi' => array(" >> $FTO
echo "			'url' => 'http://${ASTERISKAPI}/api'," >> $FTO
echo "			'localUrl' => 'http://${ASTERISKAPILOCAL}/api'," >> $FTO
echo "			'key' => '61525127357125752'," >> $FTO
echo "			'callbackUrl' => 'http://${HTTPAUTH}${APPTYPE}.taxi.dancosoft.com/site/callbackAutodial'," >> $FTO

if [ "$FIXOFFICE" != "false" ] ; then
	echo "			'dialChannel' => 'DAHDI/g1/{{phone}}@sip'," >> $FTO
else
	echo "			//'dialChannel' => 'DAHDI/g1/{{phone}}@sip'," >> $FTO
fi

echo "		)," >> $FTO
echo "		'ajam' => array(" >> $FTO
echo "			'username' => 'manager'," >> $FTO
echo "			'secret' => 'ggnore'," >> $FTO
echo "			'rawmanUrl' => 'http://${HTTPAUTH}${APPTYPE}.taxi.dancosoft.com/asterisk/rawman'," >> $FTO
echo "			'mxmlUrl' => '/asterisk/mxml'," >> $FTO
echo "		)," >> $FTO
echo "		'sipclient' => array(" >> $FTO
echo "			'sipServer' => '${SIPSERVER}'," >> $FTO
echo "		)," >> $FTO
echo "		'fixOffice' => ${FIXOFFICE}" >> $FTO
echo "	)," >> $FTO
echo ");" >> $FTO

echo "server" > protected/config/config.type
chmod a+r protected/config/common.server.php
chmod a+r protected/config/config.type
echo "[- config]"

echo "[+ prepare]"
./protected/yiic lessc
chmod a+r public/css/application.css
echo "yes" | ./protected/yiic migrate
./protected/yiic build
chmod a+r public/js/production.js
echo "[- prepare]"

popd &> /dev/null
echo "[- updating $APPTYPE]"
