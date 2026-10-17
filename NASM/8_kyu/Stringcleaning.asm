section .text

global clean_string

; char *clean_string (char *string)
clean_string:
    mov rax, rdi            ; return value = original pointer
    mov rsi, rdi            ; RSI = read pointer, RDI = write pointer

.loop:
    movzx ecx, byte [rsi]   ; load next input byte
    inc rsi
    lea edx, [rcx - '0']    ; DL = c - '0'
    cmp dl, 9
    jbe .loop               ; 0..9 means it's a digit, so skip it (don't write)

    mov [rdi], cl           ; keep this char (also copies the terminating 0)
    inc rdi
    test cl, cl
    jnz .loop               ; stop after writing the null terminator
    ret
