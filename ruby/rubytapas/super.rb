class Parent
    def hello(subject="World")
        puts "Hello. #{subject}"
    end
end

class Child < Parent
    def hello(subject=:default)
        if subject == :default
            super()
        else
            super(subject)
        end
        puts "How are you today?"
    end
end

Child.new.hello("Bob")
