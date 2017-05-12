#!/bin/bash
for ((number=1;number < 10000;number++))
{
  clear
  echo "- Free Parking/"
  git status
  echo "-             -"
  iostat
  echo "- JsWatt.github.io/"
  cd ../../../JsWatt.github.io/
  git status
  cd ../Free-Parking/shell/monitor_system/
  sleep 60
  
}
exit 0
