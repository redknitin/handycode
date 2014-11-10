<?php
require_once 'Net/LDAP2.php';

$cfg = array(
'binddn'=>'mydomain\myuser', //'cn=myuser,ou=users,dc=mydomain,dc=local',
'bindpw'=>'mypassword',
'basedn'=>'dc=mydomain,dc=local',
'host'=>'mydomain.local'
);

$ldap = Net_LDAP2::connect($cfg);

if (PEAR::isError($ldap)) {
	die('Could not connect to LDAP-server: '.$ldap->getMessage());
} else {
	echo 'Connect OK';
}