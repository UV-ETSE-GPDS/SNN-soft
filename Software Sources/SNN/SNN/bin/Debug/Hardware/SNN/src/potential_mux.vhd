library IEEE;
use IEEE.std_logic_1164.all;
use IEEE.std_logic_arith.all;
use IEEE.std_logic_unsigned.all;
use WORK.globals.all;

entity potential_mux is	
	GENERIC (inputs_number : natural := input_number); -- assign dependent on to which layer neuron belongs to
	port(
		psp_lines : in wires(0 to inputs_number); -- 0 to N because line "0" is for adder resetting
		weights_lines : in wires(0 to inputs_number);
		reset : in std_logic;
		fast_clk : in std_logic; 
		clk : in std_logic;		   
		end_add : out std_logic;
		output_to_sumator : out data_type
	);
	
end potential_mux;


architecture potential_mux of potential_mux is

component mulUnit 
		port( A,B : in data_type;
				P : out data_type);
end component;
																					
signal A_signal,B_signal,P_signal : data_type;

signal counter : integer range 0 to inputs_number;
signal flag  : std_logic;	 
signal flag2 : std_logic;
signal out_sum : std_logic;

begin
	
	
	mulMap : mulUnit port map (
					A=>A_signal,
					B=>B_signal,
					P=>P_signal		
					);
	
	process(reset,clk, counter, P_signal)
	begin
		
		
		if(reset = '0' ) then --or (counter = (inputs_number)) then
			flag <= '0';   
		elsif(counter = (inputs_number))then
			out_sum <= '1';
		elsif(rising_edge(clk)) then
			flag <= '1';
			out_sum <= '0';	 
		end if;

	end process;
	
	process(reset, flag, fast_clk) 
	begin
			if(reset = '0') then
			  counter <= 0;	
			elsif(rising_edge(fast_clk)) then	 
				if(flag = '1') then
			  		if(counter = (inputs_number))	then
						counter <= 0;  
					--flag <= '0';
					else
						counter <= counter + 1;	
					end if;
				else
					counter <= 0;  
				end if;	
				if(P_signal = zero)then
					end_add <= out_sum;	  
				end if;
			end if;	 	

			A_signal <= psp_lines(Conv_Integer(counter));
			B_signal <= weights_lines(Conv_Integer(counter));	
	end process;
	

			
	output_to_sumator <= P_signal; 

	
end potential_mux;
