.ORIG x3000
LEA R2, xFF
LDR R1, R2, x0
LDR R3, R2, x1

;x+y
ADD R4, R1, R3
STR R4, R2, x2
;x AND y
AND R4, R1, R3
STR R4, R2, x3
;x OR y
NOT R5, R1
NOT R6, R3
AND R4, R5, R6
NOT R4, R4
STR R4, R2, x4
;NOT(x)
NOT R4, R1
STR R4, R2, x5
;NOT(y)
NOT R4, R3
STR R4, R2, x6
;x+3
ADD R4, R1, #3
STR R4, R2, x7
;y-3
ADD R4, R3, #-3
STR R4, R2, x8
;x even or odd
AND R4, R1, x1
STR R4, R2, x9
HALT
.END

.ORIG x3100
.FILL #9
.FILL #-13
.END
