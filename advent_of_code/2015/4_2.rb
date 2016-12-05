require 'openssl'
input = 'iwrupvqb'
range = 0..1.0/0
range.each do |x|
  md5 = OpenSSL::Digest::MD5.hexdigest(input + x.to_s)
  if md5 =~ /^000000/
    p x.to_s << " : " << md5.to_s
  end
end
