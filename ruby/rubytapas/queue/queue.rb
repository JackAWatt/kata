queue = []
queue << :a << :b << :c
1.upto(6) do |n|
    Thread.new do puts "Thread #{n}: Got #{queue.shift.inspect}" end
end
Thread.pass
queue << :d << :e << :f
(Thread.list - [Thread.main]).each &:join

0ZZ
