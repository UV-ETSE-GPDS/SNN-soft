library IEEE;
use IEEE.std_logic_1164.all;
use IEEE.std_logic_arith.all;
use IEEE.std_logic_signed.all;
use WORK.globals.all;

entity psp_generator_basic is				
	GENERIC(weight_init : std_logic_vector(num_bits - 1 downto 0) := "00000000000000000000000100000000000000000000");
	port( clk : in std_logic;
		  reset   : in std_logic;
		  delayed_spike : in std_logic;				   
		  weight: inout std_logic_vector(num_bits - 1 downto 0);
		  refractory : in std_logic;
		  potential : out data_type
		 );
	
end psp_generator_basic;


architecture psp_generator_basic of psp_generator_basic is

signal counter : integer range 0 to psp_length ;

begin			


	process(reset,delayed_spike,clk)
	variable psp_flag : std_logic := '0';
	begin
		
		if(reset = '0') then
			counter <= 0;
			psp_flag := '0'; 
			weight <= weight_init;
		elsif rising_edge(clk) then	
			if(refractory = '1') then
		 		counter <= 0;
				 psp_flag := '0';
			else
				if(delayed_spike = '1') then
		 			psp_flag:='1';
					counter <= 0;
				end if;
		  		if(psp_flag = '1')then
					if(counter >= psp_length)then
						counter <= 0;
						psp_flag := '0';
					else
						counter <= counter + 1;
					end if;
				end if;
				--else
					--counter <= 0; 
			end if;
		end if;
		
	end process;
	
   	potential <= real_psp(Conv_Integer(counter));
	
end psp_generator_basic;
