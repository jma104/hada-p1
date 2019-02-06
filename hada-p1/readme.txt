Javier Martínez Albaladejo

P1.
	The -n option in the revert command means that the changes are not commited after reverting.
P2.
	The deletion of the file has been unmade and the commit in which it was deleted is not there anymore. 
	Now the HEAD is the previous commit.
P3.
	The revert command makes the inverse changes of the commit specified. Then you have to commit those changes.
	The reset command, in contrast, rolls back the changes made after the commit specified and makes as if they had not been made: the commits do not appear in the log.
