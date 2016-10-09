require 'net/http'
require 'redis'
require 'json'
#require 'uri'
#r = Redis.new
#counter = 0
#
#uri = URI("https://gist.github.com/JsWatt/59f4b8ce6bbf0c7e4dc7")
#page = Net::HTTP.get(uri)
#email_regex = /[\w.]{3,}[@][\w]{1,}[.][\w]{1,}/
#email_list = page.scan(email_regex)
##uri_list = page.scan(URI.regexp)
#
#puts "And finally, we close it."
#
#email_list.each { |i| r.set(counter = counter + 1 , i) }
#counter = 0
#email_list.each { |i| p r.get(counter = counter + 1) }
#r.set("this", "that")
#r.set("this", "woot woot")
#p r.get("this")
