system "clear" or system "cls"
def r(a,b)
    rnd = Random.new
    rnd.rand(a..b)
end
while :True
    print r(1,126).to_s << "." << r(0,255).to_s << "." << r(0,255).to_s << "." << r(1,254).to_s
    print " is class A"
    sleep 0.09
    print "and responds? \n"
end

