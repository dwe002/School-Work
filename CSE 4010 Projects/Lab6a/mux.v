//Multiplexer module
module mux (
    output wire [31:0] y,   // Output wire of Mux
    input wire [31:0] a,    // Input wire a of Mux
                      b,    // Input wire b of Mux
    input wire sel          // Select Input
    );

    assign y = sel ? a : b; // Mux

endmodule