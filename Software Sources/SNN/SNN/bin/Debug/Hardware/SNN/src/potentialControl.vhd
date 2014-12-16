library IEEE;
use IEEE.std_logic_1164.all;
use IEEE.std_logic_arith.all;
use IEEE.std_logic_unsigned.all;
use WORK.globals.all;


entity potentialControl is 
	
	port(
		potential_To_Compare : in data_type;
		clk : in std_logic;
		reset : in std_logic;
		in_refractory :	out std_logic;
		fire_spike : out std_logic
	);
	
end potentialControl;


architecture potentialControl of potentialControl is

signal count_refractor : integer range 0 to refractory_period_duration + 1;
signal refractor_flag : std_logic := '0';

begin

	process(potential_To_Compare,clk)
	begin
		
		if(reset = '0')then
			refractor_flag <= '0';
			fire_spike <='0';
			count_refractor <= 0;
			in_refractory <= '0';		
		--elsif(rising_edge(clk)) then
		else	
			if(refractor_flag = '0') then
				if(potential_To_Compare >= threshold) then
						refractor_flag <= '1';
						in_refractory <= '1';
						fire_spike <= '1';
						count_refractor <= count_refractor + 1;							
				end if;	
			else
				if(rising_edge(clk)) then
				count_refractor <= count_refractor + 1;
				if(count_refractor = refractory_period_duration) then
					in_refractory <= '0';
					refractor_flag <= '0';
					count_refractor <= 0;
				end if;
				fire_spike <= '0';		
				end if;
			end if;			
		
		end if;
		
	end process;		

end potentialControl;
