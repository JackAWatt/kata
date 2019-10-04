p true.class ,
    false.class, 1.class, 
    0.class, TrueClass.ancestors, 
    FalseClass.ancestors, 
    true.methods.count, 
    false.methods.count, 
    (true.methods & false.methods).count,
    ((true.methods & false.methods) - Object.instance_methods)