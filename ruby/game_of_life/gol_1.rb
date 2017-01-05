
def x_or_y
        if rnd == 1 then
                  return "|"
                      else
                                return " "
                                    end
end

def rnd
      prng = Random.new
        
        return prng.rand(2) 
end


def get_str
      str = ""
        (0..100).to_a.each do |x|
              str << (x_or_y)
                end
          return str
end
def get_grid(grid,n)
    if n == 0 then
        return grid
    else
        grid << get_str
        get_grid(grid,n-1)
    end
end
while 1

    values = get_grid(Array[],108)
    values.each do |x|
        p x
    end
    system "clear"
end
