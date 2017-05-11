#!/bin/bash
for ((number=1;number < 10000;number++))
{
  clear
  git status
  iostat
  sleep 6
}
exit 0
