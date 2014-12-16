library IEEE;
use IEEE.std_logic_1164.all;
use IEEE.std_logic_arith.all;
use IEEE.std_logic_signed.all;
use WORK.globals.all;


entity freqDiv is	
	port(
		external_clk : in std_logic;
    	reset : in std_logic;
		out_clk : inout std_logic	
	);
end freqDiv;
	   
architecture freqDiv of freqDiv is
	signal counter : std_logic_vector(31 downto 0);
begin
	
  process(reset,external_clk)
	begin
	if(reset = '0') then
		counter <= (others => '0');
		out_clk <= '0';
	elsif(rising_edge(external_clk))then
		counter <= counter + 1;
		if(counter = frequency_div) then
			out_clk <= not out_clk;
			counter <= (others => '0');
		end if;		
	end if;
  end process;
end freqDiv;
