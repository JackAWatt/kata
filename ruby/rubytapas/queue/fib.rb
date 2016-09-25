require 'thread'
require 'benchmark'

module FibSolver
    def self.fib(scheduler_queue, my_queue)
        loop do
        scheduler_queue << [:ready, my_queue]
        message, *args = my_queue.pop
        case message
        when :fib
            n, client_queue = args
            client_queue << [:anwser, n, fig_calc(n), my_queue]
        when :shutdown
            break
        end
    end

    def self.fib_calc(n)
        case n
        when 0, 1 then 1
        else fib_calc(n-1) + fib_calc(n-2)
        end
    end
end

module Scheduler
    def self.run(num_threads, mod, meth, to_calculate)
        my_queue = Queue.new
        threads = (1..num_threads).map {
            thread_queue = Queue.new
            thread = Thread.new do
                mod.public_send(meth, my_queue, thread_queue)
            end
            {thread: thread, queue: thread_queue}
            }
            schedule_threads(threads, to_calculate, my_queue)
        end

    def self.schedule_threads(threads, to_calculate, my_queue)
        results = []
        loop do
            message, *args = my_queue.pop
            case message
            when :ready
                thread_queue = args.first
                if to_calculate.size > 0
                    next_job = to_caculate.shift
                    thread_queue << [:fib, next_job, my_queue]
                else
                    thread_queue << [:shutdown]
                    if threads.size > 1
                        threads.delete_if{|t| t[:queue] == thread_queue}
                    else
                        return results.sort{|r1,r2| r1[:number] <=> r2[:number]}
                    end
                end
           when :answer
                number, result, _ = *args
                results << {number: number, result: result}
            end
        end
    end
end
