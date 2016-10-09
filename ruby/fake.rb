require 'net/http'
require 'uri'

system "clear" or system "cls"
uri = URI("https://gist.github.com/JsWatt/59f4b8ce6bbf0c7e4dc7")
page = Net::HTTP.get(uri)
email_regex = /[\w.]{3,}[@][\w]{1,}[.][\w]{1,}/
url_regex = /^(https?:\/\/)?([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?$/

email_list = page.scan(email_regex)
p uri_list = page.scan(url_regex)
