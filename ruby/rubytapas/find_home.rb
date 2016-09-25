require 'etc'


user = Etc.getlogin

config_file = File.join(Dir.home(user), ".freetacos")