library IEEE;
use IEEE.std_logic_1164.all;
use IEEE.std_logic_arith.all;
use IEEE.std_logic_signed.all;
use WORK.globals.all;	

entity timer is
	port(
		clk : in std_logic;
		reset : in std_logic;
		timer_time : out std_logic_vector(31 downto 0)
	);
end timer;

--}} End of automatically maintained section

architecture timer of timer is
signal counter : std_logic_vector(31 downto 0);
begin

	process(clk,reset)
	begin
		if(reset = '0')then
			counter <= (others => '0');	
		elsif(rising_edge(clk))then
			if(counter = (counter'range => '1')) then
				counter <= (others => '0');
			else
				counter <= counter + 1;
			end if;
		end if;
	end process;								  
	
	timer_time <= counter;

end timer;
