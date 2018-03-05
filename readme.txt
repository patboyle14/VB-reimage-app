#Updates v1.0 release 2/28/2018
1. Included catch ex message boxes for inside the copy method for -each- file instead of the whole method.
2. Forced file overwrites
3. Excluded hidden and system files
4. Updated subfolder method
5. Changed update-progress-bar to directories instead of 
6. Added whole debug interface
7. Added main layout form

#Updates v1.1 release 2/29/2018
1. Added external hdd image option
2. Updated Progress bar method
3. Updated files copied method
4. Updated copy method to call a worker thread
5. Fixed directory listing (# of bytes to copy to) to not count hidden files

#Updates v1.2 release 3/5/2018
1. Completely revamped progress bar method - threw it on a second thread with BGW's
2. Included more error checking for directories existing