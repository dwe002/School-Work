.ORIG X3000
Restart LEA R0, Prompt
PUTS

GETC

ADD R3, R0, #0
ADD R3,R3, #-16
ADD R3,R3, #-16
ADD R3,R3, #-16

LEA R0, Days

ADD R1, R3, #0
BRn Invalid
ADD R1, R3, #-6
BRp Invalid


ADD R3, R3, #0

Loop BRz DISPLAY
ADD R0, R0, #10
ADD R3, R3, #-1
BR Loop
DISPLAY PUTS

LD R0, Newline
OUT
BR Restart

Invalid 

HALT

Prompt .STRINGZ "Enter a number (0-6)"

Days .STRINGZ "Sunday   "
     .STRINGZ "Monday   "
     .STRINGZ "Tuesday  "
     .STRINGZ "Wednesday"
     .STRINGZ "Thursday "
     .STRINGZ "Friday   "
     .STRINGZ "Saturday "
 
Newline .FILL x0A

.END

