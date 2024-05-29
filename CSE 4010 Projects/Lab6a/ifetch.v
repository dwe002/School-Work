// Include .v files
`include "mux.v"
`include "mem.v"
`include "incr.v"
`include "if_id.v"
`include "pc_mod.v"

// The ifetch module of theb IF stage of the pipeline
module I_FETCH (
    output wire [31:0] IF_ID_instr,     // Output
    output wire [31:0] IF_ID_npc,       // Output
    input wire         EX_MEM_PCSrc,    // Input
    input wire [31:0]  EX_MEM_NPC      // Input
    );

    //signals
    wire [31:0] PC;
    wire [31:0] dataout;
    wire [31:0] npc,npc_mux;

    //instantations
mux mux1 (.y(npc_mux),
        .a(EX_MEM_NPC),
        .b(npc),
        .sel (EX_MEM_PCSrc));

pc_mod pc_mod1 (.PC(PC),
                .npc(npc_mux));

memory memory1 (.data(dataout),
                .addr(PC));

if_id if_id1   (.instrout(IF_ID_instr),
                .npcout(IF_ID_npc),
                .instr(dataout),
                .npc(npc));
// displays output variables
initial begin
    $display("Time\t PC\t npc\t dataout of MEM\t IF_ID_instr\t IF_ID_npc");
    $monitor("%0d\t %0d\t %0d\t %h\t %h\t %d0", $time, PC, npc, dataout, IF_ID_instr, IF_ID_npc);
    #20 $finish;
    end

endmodule


