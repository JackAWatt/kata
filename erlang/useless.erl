-module(useless).
-export([add/2,hello/0,greet_and_add_two/1]).


add(A,B) ->
        funky_math(A) + funky_math(B).
        
    funky_math(A) ->
            A * 1.003.
            
        hello() ->
                io:format("Hello, world!~n").
                
            greet_and_add_two(X) ->
                    hello(),
                        add(X,2).
