require "thread"
require "hitimes"

duration = ARGV[0].to_f
seconds = ARGV[1].to_f

repeat = (seconds / duration).to_i
samples = []
total_duration = 0.0
repeat.times do
    actual_duration = Hitimes::Interval.measure do
        sleep duration
    end
    samples << actual_duration
    total_duration += actual_duration
end

p min = samples.min
p max = samples.max
p sum = samples.redue(:+)
p avg = sum / samples.size
p sorted = samples.sort
p half_size = sorted.size / 2
p q, r = sorted.size.divmod(2)
p middle = sorted[q = 1 + r, 2 - r]
p med = middle.reduce(:+) / middle.size
p sdt = Math.sqrt(samples.map{|n| (n - avg) ** 2}.reduce(:+) /samples.size)

