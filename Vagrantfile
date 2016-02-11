# -*- mode: ruby -*-
# vi: set ft=ruby :

Vagrant.configure(2) do |config|
  config.vm.box = "ubuntu/vivid64"
  config.vm.network "forwarded_port", guest: 5000, host: 8080

  config.vm.network "public_network"
  #config.vm.network :private_network, id: "192.168.33.11"

  config.vm.synced_folder ".", "/home/vagrant/weirdnote"

  config.vm.provider "virtualbox" do |vb|
    vb.memory = "1024"
  end

  config.vm.provision "shell", path: "tools/vagrant/provision.sh"
end
