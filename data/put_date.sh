#!bin/bash
user_file_name=$1
defined_file_name=data.txt
if [ $# = 0 ]; 
then 
    date > $defined_file_name
else 
    date > $user_file_name
fi