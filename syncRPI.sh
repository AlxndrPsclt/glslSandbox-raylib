#!/usr/bin/env sh

rsync -rvz -e ssh --exclude-from='.rsyncignore' --progress $(pwd) alex@192.168.8.126:/home/alex/projects/shaders/
