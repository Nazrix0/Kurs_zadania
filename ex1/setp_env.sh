#!/usr/bin/env bash

TARGET="$1"
./check_target.sh $TARGET
res=$?
if [ "$res" != 0 ];then
    exit 1
fi

ssh 192.168.56.123 'mkdir bin; mkdir tmp'
