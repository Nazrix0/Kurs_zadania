#!bin/bash

if [ $# = 0 ]; 
then 
    date > data.txt
else 
    date > $1
fi