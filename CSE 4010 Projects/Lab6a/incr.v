// Incrementer module
module incrementer (
    input wire [31:0] pcin,     // Input of increment
    output wire [31:0] pcout    // Output of increment
    );
    assign pcout = pcin + 1;    // Increment pc by 1
endmodule