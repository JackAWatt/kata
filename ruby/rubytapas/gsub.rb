TEXT = <<EOF
doug cat, dog bountry, try, tuck, them, they
hey, I'm bob, what is what is who?
dog
EOF

LEXICON = {
    "doug" => "DOUG",
    "bob" => "BOB",
    "dog" => "DOG"
    
}

terms = LEXICON.keys.map{|k| Regexp.escape(k)}.join("|")
pattern = Regexp.new(terms)

sanitized = TEXT.gsub(pattern, LEXICON)
puts sanitized