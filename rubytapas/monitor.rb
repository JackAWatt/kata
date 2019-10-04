require "monitor"
class Scores
    include MonitorMixin
    def inialize
        @scores = {}
    end

    def update(turtle, score)
        synchronize do
            @scores[turtle] = score
        end
    end

    def for_turtle(turtle)
        synchronize do
            @scores[turtle]
        end
    end

    def for_all(*turtles)
        synchronize do
            turtles.map {|t| for_turtle(t)}
        end
    end
end

p scores = Scores.new
p scores.update("yertle", 23)
p scores.update("mack", 15)
p scores.for_turtle("mack")

