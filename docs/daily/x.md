#What happens ...

This is about how fork and exec works on Unix. You might already know about this, but some people don’t, and I was surprised when I learned it a few years back!

So. You want to start a process. We’ve talked a lot about system calls on this blog – every time you start a process, or open a file, that’s a *system call*. So you might think that there’s a system call like this

###fork and exec
`posix_spawn` on Linux is behind the scenes implemented in terms of 2 system calls called `fork` and exec (actually `execve`), which are what people usually actually use anyway. On OS X apparently people use `posix_spawn` and fork/exec are discouraged! But we’ll talk about Linux.
