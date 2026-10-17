section .text

global clean_string

; char *clean_string (char *string)
clean_string:
    ;  mutate the string in-place and return it
    mov rax, rdi    ; RAX = output, RDI = input
    ret
