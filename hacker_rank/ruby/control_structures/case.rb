def identify_class(obj)
    hacker = "It's a Hacker!\n"
    if (obj.instance_of? Hacker)
        print hacker
    elsif (obj.instance_of? Submission)
        print "It's a Submission!\n"
    elsif (obj.instance_of? TestCase)
        print "It's a TestCase!\n"
    elsif (obj.instance_of? Contest)
        print "It's a Contest!\n"
    else
        print "It's an unknown model\n"
    end
end
