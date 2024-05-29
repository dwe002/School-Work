// The IF stage of the pipeline module
module if_id (
    output reg [31:0] instrout,  // Inputs of increment
                        npcout,
    input wire [31:0]    instr,     // Outputs of increment
                           npc
    );

    //points variables
    initial begin
        instrout <= 0;
        npcout   <= 0;
    end
    //points variables to initialized variables
    always @* begin
        #1 instrout <= instr;
             npcout <= npc;
    end
endmodule