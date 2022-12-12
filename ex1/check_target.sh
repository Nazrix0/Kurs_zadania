#!/usr/bin/env bash
TARGET=192.168.56.123
if [ "$1" != "" ];then  
    TARGET="$1"
fi 

ping $TARGET -c1 -t1 > /dev/null 2>&1
res=$?
if [ "$res" == 1 ];then
    echo "Target $TARGET is not reachable"
    exit -1
else
    echo "Target $TARGET is reachable"
fi

exit $res