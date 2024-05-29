// Instruction memory module
module memory (
    output reg [31:0] data,     // Output
    input wire [31:0] addr      // Input 
    );

    //Register declarations
    reg [31:0] MEM[0:127];      // 128 words of 32 bit memory

    //Inititalize registers
    initial begin
    //Memory cells
    MEM[0] <= 'hA00000AA;
    MEM[1] <= 'h10000011;
    MEM[2] <= 'h20000022;
    MEM[3] <= 'h30000033;
    MEM[4] <= 'h40000044;
    MEM[5] <= 'h50000055;
    MEM[6] <= 'h60000066;
    MEM[7] <= 'h70000077;
    MEM[8] <= 'h80000088;
    MEM[9] <= 'h90000099;
    end
    // I type intrsuction
    always @ (addr) data <= MEM[addr];
endmodule
