//Program counter module
module pc_mod (
    output reg [31:0] PC,   // Output
    input wire [31:0] npc   // Input
    );

    //initializes counter
    initial begin
        PC <= 0;
    end
    //points to next instruction
    always @ ( npc) begin
        #1 PC <= npc;
    end

endmodule