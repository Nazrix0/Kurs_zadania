#!/usr/bin/env bash

TARGET=192.168.56.123

LOCAL_MACHINE_IP=192.168.56.102

file_torun_remote="top_df_local.sh"

ping $TARGET -c1 -t1 > /dev/null 2>&1
res=$?
if [ "$res" == 1 ];then
    echo "Target $TARGET is not reachable"
    exit 1
else
    scp  "$file_torun_remote" $TARGET:
    ssh $TARGET ' source '$file_torun_remote' ; scp "./$folder_name/$file_name" '$LOCAL_MACHINE_IP':./code/ex2/'
fi
