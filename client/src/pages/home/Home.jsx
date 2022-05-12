import React, { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import { useForm, Controller } from "react-hook-form";
import SessionAPI from "../../apis/Sessionapi";
function HomePage() {
  const history = useNavigate();

  const { control, handleSubmit, watch, setValue, getValues } = useForm({
    defaultValues: {
      username: "",
      password: "",
    },
  });

  const [passVisible, setPassVisible] = useState(false);

  const onSubmit = async (data) => {
    await SessionAPI.Login(data).then((data) => {
      console.log("response data:");
      console.log(data);
    });
    // console.log(data);
  };
  return (
    <>
      <form className="container shadow-lg" onSubmit={handleSubmit(onSubmit)}>
        <span>Login</span>
        <div className="">
          <label htmlFor="">Username</label>
          <br />
          <Controller
            name="username"
            control={control}
            render={({ field: { onChange } }) => (
              <input
                type="text"
                placeholder="Enter Username"
                value={watch("username")}
                onChange={onChange}
              />
            )}
          />
        </div>
        <div>
          <label htmlFor="password">Password</label>
          <br />
          <Controller
            name="password"
            control={control}
            render={({ field: { onChange } }) => (
              <input
                type={`${passVisible ? "text" : "password"}`}
                placeholder="Enter Username"
                value={watch("password")}
                onChange={onChange}
              />
            )}
          />
          <button
            type="button"
            onClick={() => {
              setPassVisible(!passVisible);
            }}
          >
            {passVisible ? "hide" : "show"}
          </button>
        </div>

        <button type="submit">login</button>
      </form>
    </>
  );
}

export default HomePage;
