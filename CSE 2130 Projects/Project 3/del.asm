  .ORIG x3000

       AND R0,R0, #0

       AND R2,R2, #0

       ADD R2,R2, #7

       JSR SUB

       ADD R2,R2, ASCII

       ADD R0,R2,#0

       TRAP x21

SUB      ADD R2,R2,#9

       ADD R7,R7,#1

       RET

ASCII .FILL x0030

.END