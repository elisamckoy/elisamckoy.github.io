# Practice Git

At this point, you have a good understanding of git and the command line. You've also installed sublime and git on your computer and have a Github account. Now, we're going to practice Git/Github a little to solidify what you've learned.

## Fork the Phase-0 Repo 

Go to the [root](../../../../..) of this repo. At the top of the page, there's a fork button. Press it. You'll be prompted to choose a repository to fork to. Choose yours. You should now have a copy of our repo in your github account. 

## Clone your Copy of the Phase-0 Repo

Now, you're going to clone (aka make a local copy of) your forked repo.

First, go to your forked Phase-0 Repo on Github. At the bottom of the right sidebar, you'll find a little HTTPS clone url. Copy this url to your clipboard. 

Now, using the command line, navigate to wherever you want to store your local copy. 

Once you're in the directory, run the following command: ``` git clone the_url_that_you_copied ```. Now you have a local copy of the repo! This means that you can view all of its contents at any time, even if you don't have internet. This also means that you can open and edit any of the contents with your favorite text editor. How nice.

## Edit!

Now you're going to make some edits to your local copy. 

First, cd into the git_practice folder in week_1 of unit_1, and run: ```git checkout -b "meowtown"```. This will create a new branch called "meowtown". Now you can make edits without affecting the master branch of our repo. The master branch is only for stuff which is totally complete, tested, reviewed, etc. We will eventually merge our branch into master when we're all done. 

Great. Now, create a file called MEOWTOWN.md in the git_practice directory, and open it in Sublime. If you're on mac/linux, you can use the following command: ```subl MEOWTOWN.md```. If that doesn't work, or if you're on windows, open the file with Sublime manually.

In Sublime, add the following to your MEOWTOWN.md file:
``` 
# O YA IT'S MEOWTOWN

![real life cat](https://www.petfinder.com/wp-content/uploads/2012/11/99059361-choose-cat-litter-632x475.jpg)
```

## Commit and Push to Github!
We've made our edits, and now we want to save them both locally and remotely. To do this:

Run: ```git status``` to confirm that your changes were made.

Run: ```git add .``` to stage your changes (the . means "everything in this directory")

Run: ```git status``` to confirm that your changes were staged

Run: ```git commit -m "added soul animal to meowtown"``` to commit your staged changes

Run" ```git status``` to confirm that your changes were committed

Run: ```git push origin meowtown``` to push your commits up to the meowtown branch on github.

## Create a Pull Request + Merge
If you take a look at your forked phase 0 repo on github, you should see a little notification containing your recently pushed branches. There should be a green button that says "Compare and Pull Request". Click this button. You will be redirected to a new page. At the top of this page, there will be dropdown bar for "base fork" and a dropdown bar for "head fork". You're going to want to switch the "base fork" from "dev-academy-phase0/phase-0-version-2.0" to "your-github-username/phase-0-version-2.0". The page will reload, and some comment boxes will appear. Add some if you want, and when you're done click the "Create Pull Request" button.

You've just created a pull request! When you do this, anyone else working on the repo is notified. If you were working with other people, they would review your changes, comment on them, maybe edit your work a bit further, etc. At some point all of you would reach a consensus, agreeing that the changes should be merged into master. At this point, someone would click the "Merge Pull Request" button. 

Since you're not really working with a team right now, and since your changes are legitimately perfect. We'll just go ahead and merge. After merging, we'll delete the old branch, and navigate to the MEOWTOWN.md file on github. If there's a picture of a cat there, then you've done everything perfectly.

Wonderful work -- have a beer :beer:

## Summary

Take a moment to review. What you just did, you will end up doing over and over and over again. 

Consider making a list of all the git commands you just used. Think of them as tools and for each tool think to yourself: What does this tool do? How do I use it? When would I use it? Why is this tool helpful?
 
