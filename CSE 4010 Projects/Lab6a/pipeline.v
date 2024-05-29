//include .v file
`include "ifetch.v"

//module that simulates the function of the IF stage of the pipeline
module pipeline ();

    //wires
    wire[31:0] IF_ID_instr, IF_ID_npc; 
    reg EX_MEM_PCSrc;
    reg [31:0] EX_MEM_NPC;
        //fetches variables
        I_FETCH I_FETCH1( .IF_ID_instr(IF_ID_instr),
                          .IF_ID_npc(IF_ID_npc),
                          .EX_MEM_PCSrc(EX_MEM_PCSrc),
                          .EX_MEM_NPC(EX_MEM_NPC) );
        //initializes variables
        initial begin
        EX_MEM_PCSrc <= 0;
        EX_MEM_NPC <= 0;
        end


endmodule

