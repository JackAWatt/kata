md_files = Dir.glob("[0-9]*.md")  

x = md_files.sort
p x[x.length - 1]
