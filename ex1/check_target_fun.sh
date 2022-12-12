#!/usr/bin/env bash

check_ip(){
TARGET=$1
ping $TARGET -c1 -t1 > /dev/null 2>&1
res=$?
if [ "$res" == 1 ];then
    echo "Target is not reachable"
else
    echo "Target is reachable"
fi

return $res
}
