require 'net/http'
require 'json'
require 'uri'
counter = 0

uri = URI("https://gist.github.com/JsWatt/59f4b8ce6bbf0c7e4dc7")
page = Net::HTTP.get(uri)
email_regex = /[\w.]{3,}[@][\w]{1,}[.][\w]{1,}/
email_list = page.scan(email_regex)
magnet_regex = /magnet:\?xt=urn:[a-z0-9]{20,50}/
magnet_list = page.scan(magnet_regex)
email_list.each do |x|
    p x
end

magnet_list.each do |x|
    p x
end
