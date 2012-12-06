#Project Conventions


1. Convention for configuration
    * All micro config files will live under the source/config folder and have an .erb extension. These files will be transformed and copied to all necessary locations for runtime and test time.
2. All component collaborators are guaranteed to not be null (component layer responsibility)

3. 1 Command Per Unique Request

4. 1 Logical View Per Report Model

5. 1 Model In 1 Model Out
