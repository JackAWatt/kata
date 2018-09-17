class Imp
  def greet(title, full_name)
    salutation = "Most agreeable to see you"
    full_name = "sam vimes"
    version = "Mark 7"

    puts "#{salutation},#{full_name}. ",
       "Your version is #{version}. ",
       "Your title is #{title}. "
  end
end

Imp.new.greet "commander", "Sam Vimes"
