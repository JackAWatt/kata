require 'logger'

class NullLogger
    def debug(*); end
    def info(*); end
    def warn(*); end
    def error(*); end
    def fatal(*); end
end

class Picard
    def make_it_so(log=Logger.new($stdout))
        log.info "I have instructed eningeering to fix my tea kettle"
        Geordi.new(log).fix_it
    end
end

class Geordi
    def initialize(log, options={})
        @log = log
    end

    def fix_it
        @log.info "reversing the flox phase capacitance!"
        @log.into "bounding a tachyon particle beam off of Data's cat!"
        Barclay.new(@log).monitor_sensors
    end
end

log = NullLogger.new

puts "before"
Picard.new.make_it_so(log)
puts "after"
