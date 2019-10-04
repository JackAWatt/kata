p 42
p 3.3
p "foo"
p 0x7FFF
p 0755
require 'fileutils'
include FileUtils

chmod 000, "sample.txt"

#perms = 0b111101101
#perms.to_s(8)

#chmod perms, 'sample.txt'
