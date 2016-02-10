#!/usr/bin/env bash

sudo apt-get update

# DNX prerequisites
sudo apt-get install -y unzip curl libunwind8 gettext libssl-dev libcurl4-openssl-dev zlib1g libicu-dev uuid-dev

# install DNVM
curl -sSL https://raw.githubusercontent.com/aspnet/Home/dev/dnvminstall.sh | DNX_BRANCH=dev sh && source ~/.dnx/dnvm/dnvm.sh

# dnvm set as coreclr
dnvm upgrade -r coreclr

# nvm install
curl -o- https://raw.githubusercontent.com/creationix/nvm/v0.30.2/install.sh | bash
source ~/.nvm/nvm.sh

# install node
nvm install v5.5.0
nvm alias default v5.5.0

# node related
npm install -g yo bower grunt-cli gulp
npm install -g generator-aspnet
