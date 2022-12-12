#!/usr/bin/env bash
ssh 192.168.56.123 exit 0
res=$?
if [ $res = 0 ];
then
    echo "Połączenie jest możliwe"
else 
    echo "Połączenie ie jest możliwe"
fi