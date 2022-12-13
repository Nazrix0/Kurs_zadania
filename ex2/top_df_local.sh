#!/usr/bin/env bash

folder_name=$(date)
file_name=data.txt 
command_1=$(top -bn1)
command_2=$(df -h)
mkdir "$folder_name"

"$command_1" >> "./$folder_name/$file_name" 2>&1
"$command_2" >> "./$folder_name/$file_name" 2>&1

export folder_name
export file_name

