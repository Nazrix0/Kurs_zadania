#!/usr/bin/env bash

TARGET=192.168.56.123

file_torun_remote="top_df_local.sh"

ping $TARGET -c1 -t1 > /dev/null 2>&1
res=$?
if [ "$res" == 1 ];then
    echo "Target $TARGET is not reachable"
    exit 1
else
    scp  "$file_torun_remote" $TARGET:
    ssh $TARGET './$file_torun_remote; source top_df_local.sh; scp "./$folder_name/$file_name" 192.168.56.102:./code/ex2/'
fi
