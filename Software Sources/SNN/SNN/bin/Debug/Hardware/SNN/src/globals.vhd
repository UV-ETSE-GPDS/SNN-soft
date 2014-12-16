library IEEE;
use IEEE.std_logic_1164.all;
use IEEE.std_logic_arith.all;
use IEEE.std_logic_signed.all;	  


package globals is 
	-- values are coded as follows: x(DEC) * 2^20 = ToBIN(y)	
	constant num_bits : integer := 44; --32
	constant codingPower : integer := 20;
	
	-- basic network constants:
	
	constant input_number : natural := 5;
	constant layer1_number : natural := 3;
	constant output_number : natural := 3;
	
	-- types 		
	
	constant psp_length : integer := 25;  -- counter limit for psp
	
	subtype data_type is std_logic_vector ( num_bits - 1 downto 0);		   -- basic type of input/output data, bus between components
	
	subtype coded_word is std_logic_vector(num_bits - 1 downto 0);
	type function_tab is array(0 to psp_length) of coded_word; 		   -- potential function type
	
	type wires is array(natural range <>) of data_type;			   -- wires between components in neuron
	
	--subtype in_lay1_inputs is std_logic_vector(0 to input_number - 1);	   -- wires between neurons of input layer and hidden layer
	--subtype lay1_output_inputs is std_logic_vector(0 to layer1_number - 1); -- wires between neurons of hidden layer and output layer
	--subtype output_wires is std_logic_vector(0 to output_number - 1);	   -- wires for neurons of output layer
		
	-- control constants:
	constant frequency_div : integer := 100000;	 	-- gives 1ms with FPGA clock 200MHz
    constant zero : std_logic_vector(num_bits - 1 downto 0) := "00000000000000000000000000000000000000000000";
	
	-- neuron constants:
	type wires_input_to_layer1 is array (0 to layer1_number - 1) of std_logic_vector(0 to input_number - 1);
	type wires_lay1_to_output is array (0 to output_number - 1) of std_logic_vector(0 to layer1_number - 1);

	type input_delay_type is array (0 to (input_number - 1)) of natural;
	constant input_delays : input_delay_type  :=(50,50,50,50,50); 
	
    type input_lay1_type is array (0 to ((input_number * layer1_number) - 1)) of natural;
	constant input_lay1_delays : input_lay1_type  :=(10,13,6,8,17,11,8,11,8,10,5,15,19,14,10); 
	
	type lay1_output_type is array (0 to ((layer1_number * output_number) - 1)) of natural;
	constant lay1_output_delays : lay1_output_type  :=(13,17,8,11,8,10,15,19,14); 
	type lay1_weights_type is array (0 to ((input_number * layer1_number) - 1)) of coded_word;
	type output_weights_type is array (0 to ((layer1_number * output_number) - 1)) of coded_word;
	
	constant lay1_weights : lay1_weights_type := ((
	"00000000000000000000000001000000000000000000",
	"00000000000000000000000001000000000000000000",
	"00000000000000000000000001000000000000000000",
	"00000000000000000000000001000000000000000000",
	"00000000000000000000000001000000000000000000",
	"00000000000000000000000001000000000000000000",
	"00000000000000000000000001000000000000000000",
	"00000000000000000000000001000000000000000000",
	"00000000000000000000000001000000000000000000",
	"00000000000000000000000001000000000000000000",
	"00000000000000000000000001000000000000000000",
	"00000000000000000000000001000000000000000000",
	"00000000000000000000000001000000000000000000",
	"00000000000000000000000001000000000000000000",
	"00000000000000000000000001000000000000000000"));
	constant out_weights : output_weights_type := ((
	"00000000000000000000000001000000000000000000",
	"00000000000000000000000001000000000000000000",
	"00000000000000000000000001000000000000000000",
	"00000000000000000000000001000000000000000000",
	"00000000000000000000000001000000000000000000",
	"00000000000000000000000001000000000000000000",
	"00000000000000000000000001000000000000000000",
	"00000000000000000000000001000000000000000000",
	"00000000000000000000000001000000000000000000"));
	
	--constant input_firing_rate : integer := 50; --50. 100.  it is important for this constant to be greater than value of psp_length
	constant refractory_period_duration : integer := 60; -- time in ms of refractory period duration
		
	constant threshold: std_logic_vector := "00000000000000000000000000100000000000000000"; --"00000000000100000000000000000000"; -- corresponds to threshold, in this case th = 1,000
											 				   
	constant real_psp : function_tab := (( 	
  --"00000000000000010000000000000000"
  	"00000000000000000000000000000000000000000000",	
	"00000000000000000000000000101100000110011110",
	"00000000000000000000000000111101000110000011",
	"00000000000000000000000000111111110011011111",
	"00000000000000000000000000111011100010000000",
	"00000000000000000000000000110100010101001101",
	"00000000000000000000000000101100011000000011",
	"00000000000000000000000000100100110000010110",
	"00000000000000000000000000011101111101001111",
	"00000000000000000000000000011000001000110110",
	"00000000000000000000000000010011010010011111",
	"00000000000000000000000000001111010100011011",
	"00000000000000000000000000001100000111000110",
	"00000000000000000000000000001001100010101001",
	"00000000000000000000000000000111011111110100",
	"00000000000000000000000000000101111000010000",
	"00000000000000000000000000000100100110100101",
	"00000000000000000000000000000011100110010111",
	"00000000000000000000000000000010110011111111",
	"00000000000000000000000000000010001100100001",
	"00000000000000000000000000000001101101101001",
	"00000000000000000000000000000001010101100001",
	"00000000000000000000000000000001000010101011",
	"00000000000000000000000000000000110011111110",
	"00000000000000000000000000000000101000100000",
	"00000000000000000000000000000000011111100100"
	));

	
end globals;